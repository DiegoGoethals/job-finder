var app = new Vue({
    el: "#app",
    name: "app",
    data: {
        baseUrl: "https://localhost:44382/api/",
        username: "",
        password: "",
        token: "",
        email: "",
        dateOfBirth: new Date().toLocaleDateString(),
        firstName: "",
        lastName: "",
        role: "",
        selectedSkills: [],
        skills: [],
        jobs: [],
        messages: [],
        reviews: [],
        applications: [],
        newJob: {
            Name: "",
            Description: "",
            Salary: 0,
            EmployerId: "",
            Skills: []
        },
        newReview: {
            Rating: 0,
            Comment: "",
            ReviewerId: "",
            RevieweeId: ""
        },
        newMessage: {
            SenderId: "",
            ReceiverId: "",
            Content: ""
        },
        loggedIn: false,
        tokenObject: null,
        isEmployer: false,
        loading: false,
        loginFormVisible: true,
        addingNewJob: false,
        employerId: "",
        selectedJob: null,
        loggedInUsername: "",
        dropdownVisible: false,
        viewApplications: false,
    },
    created: function () {
        this.loading = true;
        if (localStorage.getItem('token') !== null) {
            this.token = localStorage.getItem('token');
            this.tokenObject = this.decodeToken(window.localStorage.getItem('token'));
            this.loggedInUsername = this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"];
            //get the role and store in sessionStorage
            const role = this.tokenObject["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
            if (role === "Employer") {
                this.employerId = this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"];
                this.isEmployer = true;
                this.getJobsByEmployer();
            }
            else {
                this.getAllJobs();
            }
            this.loggedIn = true;
        }
        this.getSkills();
        this.loading = false;
    },
    methods: {
        getSkills: async function () {
            const url = `${this.baseUrl}skills`;
            this.skills = await axios.get(url)
                .then(response => {
                    return response.data;
                })
                .catch(error => {
                    console.log(error);
                });
        },
        getAllJobs: async function () {
            const url = `${this.baseUrl}jobs`;
            this.jobs = await axios.get(url)
                .then(response => {
                    return response.data;
                })
                .catch(error => {
                    console.log(error);
                });
        },
        getJobsByEmployer: async function () {
            const url = `${this.baseUrl}jobs/employer/${this.employerId}`
            this.jobs = await axios.get(url, {
                    headers: {
                        Authorization: `Bearer ${this.token}`
                    }
                })
                .then(response => {
                    return response.data;
                })
                .catch(error => {
                    console.log(error);
                });
        },
        createNewJob: async function () {
            this.newJob.EmployerId = this.employerId;
            this.loading = true;
            await axios.post(`${this.baseUrl}jobs`, this.newJob, {
                    headers: {
                        Authorization: `Bearer ${this.token}`
                    }
                })
                .then(response => response.data)
                .catch(error => {
                    console.log(error);
                });
            this.loading = false;
            this.getJobsByEmployer();
            this.addingNewJob = false;
            this.newJob = {
                Name: "",
                Description: "",
                Salary: 0,
                EmployerId: "",
                Skills: []
            }
        },
        deleteJob: async function (jobId) {
            const url = `${this.baseUrl}jobs/${jobId}`;
            this.loading = true;
            await axios.delete(url, {
                headers: {
                    Authorization: `Bearer ${this.token}`
                }
            })
            .then(response => response.data)
            .catch(error => {
                console.log(error);
            });
            this.loading = false;
            this.getJobsByEmployer();
        },
        selectJob: function (job) {
            this.selectedJob = job;
        },
        clearSelection: function () {
            this.selectedJob = null;
        },
        applyForJob: async function () {
            const applicationDto = {
                "jobId": this.selectedJob.id,
                "salary": this.selectedJob.salary,
                "candidateId": this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"]
            };
            const url = `${this.baseUrl}applications`;
            this.loading = true;
            await axios.post(url, applicationDto, {
                headers: {
                    Authorization: `Bearer ${this.token}`
                }
            })
            .then(response => response.data)
            .catch(error => {
                console.log(error);
            });
            this.loading = false;
        },
        viewApplicationsHandler: async function () {
            this.viewApplications = true
            this.dropdownVisible = false;
            const url = `${this.baseUrl}applications/candidate/${this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"]}`;
            this.applications = await axios.get(url, {
                headers: {
                    Authorization: `Bearer ${this.token}`
                }
            })
            .then(response => {
                return response.data;
            })
            .catch(error => {
                console.log(error);
            });
        },
        deleteApplication: async function (applicationId) {
            const url = `${this.baseUrl}applications/${applicationId}`;
            this.loading = true;
            await axios.delete(url, {
                headers: {
                    Authorization: `Bearer ${this.token}`
                }
            })
            .then(response => response.data)
            .catch(error => {
                console.log(error);
            });
            await this.viewApplicationsHandler();
            this.loading = false;
        },
        submitLogin: async function () {
            const loginDto = {
                "username": this.username,
                "password": this.password
            };
            this.loading = true;
            let token = await axios.post(`${this.baseUrl}auth/login`, loginDto)
                .then(response => response.data.token)
                .catch(error => {
                    console.log(error)
                });
            this.loading = false;
            window.localStorage.setItem('token', token);
            this.tokenObject = this.decodeToken(token);
            this.loggedInUsername = this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"];
            const role = this.tokenObject["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
            if (role === "Employer") {
                this.isEmployer = true;
                this.getJobsByEmployer();
            }
            else {
                this.getAllJobs();
            }
            this.loggedIn = true;
            this.getSkills(); 
        },
        registerUser: async function() {
            const registerDto = {
                "username": this.username,
                "password": this.password,
                "email": this.email,
                "birthday": this.dateOfBirth,
                "firstname": this.firstName,
                "lastname": this.lastName,
                "role": this.role,
                "skills": this.selectedSkills
            }
            this.loading = true;
            await axios.post(`${this.baseUrl}auth/register`, registerDto)
                .then(response => response)
                .catch(error => {
                    console.log(error);
                })
            this.username = "";
            this.password = "";
            this.email = "";
            this.dateOfBirth = new Date().toLocaleDateString();
            this.firstName = "";
            this.lastName = "";
            this.role = "";
            this.selectedSkills = [];
            this.loading = false;
            this.loginFormVisible = true;
        },
        submitLogout: async function () {
            this.tokenObject = "";
            window.localStorage.clear();
            this.loggedIn = false;
            this.isEmployer = false;
            this.loggedInUsername = "";
            this.dropdownVisible = false;
            this.loading = false;
        },
        decodeToken: function (token) {
            var base64Url = token.split('.')[1];
            var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            var jsonPayload = decodeURIComponent(window.atob(base64).split('').map(function (c) {
                return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
            }).join(''));
            return JSON.parse(jsonPayload);
        },
        toggleForms: function () {
            this.loginFormVisible = !this.loginFormVisible;
        },
        toggleDropdown: function () {
            this.dropdownVisible = !this.dropdownVisible;
        },
    }
});


