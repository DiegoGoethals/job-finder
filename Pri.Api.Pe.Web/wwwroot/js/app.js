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
        applicationStatuses: [],
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
        currentUserId: "",
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
        selectedApplication: null,
        isDeleting: false,
        showMessageScreen: false,
        conversationPartners: [],
        showConversation: false,
        loginError: "",
        showFilterBar: false,
        showUserDetails: false,
        userDetailsId: "",
        userDetails: {},
        addingReview: false,
    },
    created: async function () {
        this.loading = true;
        const token = sessionStorage.getItem('token');
        if (token !== null) {
            await this.setToken(token);
        }
        await this.getApplicationStatuses();
        await this.getSkills();
        this.loading = false;
    },
    methods: {
        setToken: async function (token) {
            this.token = token;
            this.tokenObject = this.decodeToken(token);
            this.loggedInUsername = this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"];
            this.role = this.tokenObject["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
            this.isEmployer = this.role === "Employer";
            this.employerId = this.isEmployer ? this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"] : "";
            this.currentUserId = this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"];
            this.loggedIn = true;
            await this.fetchInitialData();
        },
        fetchInitialData: async function () {
            if (this.isEmployer) {
                await this.getJobsByEmployer();
            } else {
                await this.getAllJobs();
                await this.getCandidateApplications();
            }
            await this.getConversationPartners();
        },
        getApplicationStatuses: async function () {
            const url = `${this.baseUrl}applications/statuses`;
            this.applicationStatuses = await axios.get(url)
                .then(response => {
                    return response.data;
                })
                .catch(error => {
                    console.log(error);
                });
        },
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
        getConversationPartners: async function () {
            const url = `${this.baseUrl}messages/partners/${this.currentUserId}`;
            this.conversationPartners = await axios.get(url, {
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
                .then(response => this.jobs.push(response.data))
                .catch(error => {
                    console.log(error);
                });
            this.loading = false;
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
            .then(_ => this.jobs = this.jobs.filter(job => job.id !== jobId))
            .catch(error => {
                console.log(error);
            });
            this.selectedJob = null;
            this.loading = false;
            this.isDeleting = false;
        },
        filterJobs: async function () {
            const url = `${this.baseUrl}jobs/skills?skills=${this.selectedSkills.join('&skills=')}`;
            this.loading = true;
            this.jobs = await axios.get(url)
                .then(response => {
                    return response.data;
                })
                .catch(error => {
                    console.log(error);
                });
            this.loading = false;
        },
        clearFilters: async function () {
            this.selectedSkills = [];
            await this.getAllJobs();
        },
        selectJob: async function (job) {
            this.selectedJob = job;
            await this.getAppplicationsByJob();
        },
        clearSelection: function () {
            this.selectedJob = null;
            this.selectedApplication = null;
        },
        applyForJob: async function () {
            const applicationDto = {
                "jobId": this.selectedJob.id,
                "salary": this.selectedJob.salary,
                "candidateId": this.currentUserId,
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
            this.selectedJob = null;
            this.loading = false;
        },
        getCandidateApplications: async function () {
            const url = `${this.baseUrl}applications/candidate/${this.currentUserId}`;
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
        viewApplicationsHandler: async function () {
            this.viewApplications = true;
            this.showMessageScreen = false;
            this.dropdownVisible = false;
            await this.getCandidateApplications();
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
            this.selectedApplication = null;
            await this.viewApplicationsHandler();
            this.loading = false;
            this.isDeleting = false;
        },
        getAppplicationsByJob: async function () {
            const url = `${this.baseUrl}applications/job/${this.selectedJob.id}`;
            this.loading = true;
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
            this.loading = false;
        },
        selectApplication: function (application) {
            this.selectedApplication = application;
        },
        acceptApplication: async function () {
            const url = `${this.baseUrl}applications/${this.selectedApplication.id}/status`;
            const dto = this.applicationStatuses.find(status => status.name === "Accepted");
            this.loading = true;
            await axios.put(url, dto, {
                headers: {
                    Authorization: `Bearer ${this.token}`
                }
            })
            .then(response => response.data)
            .catch(error => {
                console.log(error);
            });

            //Code for rejecting all other applications
            for (let application of this.applications) {
                if (application.id === selectedApplication.id) {
                    continue;
               }
               const url = `${this.baseUrl}applications/${application.id}/status`;
               const dto = this.applicationStatuses.find(status => status.name === "Rejected");
               await axios.put(url, dto, {
                    headers: {
                        Authorization: `Bearer ${this.token}`
                    }
               })
               .then(response => response.data)
               .catch(error => {
                    console.log(error);
               });
            }
            await this.getAppplicationsByJob();

            this.loading = false;
        },
        rejectApplication: async function () {
            const url = `${this.baseUrl}applications/${this.selectedApplication.id}/status`;
            const dto = this.applicationStatuses.find(status => status.name === "Rejected");
            this.loading = true;
            await axios.put(url, dto, {
                headers: {
                    Authorization: `Bearer ${this.token}`
                }
            })
                .then(response => response.data)
                .catch(error => {
                    console.log(error);
                });
            await this.getAppplicationsByJob();
            this.loading = false;
        },
        viewMessagesHandler: async function () {
            this.showMessageScreen = true;
            this.viewApplications = false;
            this.dropdownVisible = false;
        },
        openMessages: async function (receiverId) {
            if (!this.conversationPartners.some(partner => partner.id === receiverId)) {
                const url = `${this.baseUrl}auth/${receiverId}`;
                axios.get(url, {
                    headers: {
                        Authorization: `Bearer ${this.token}`
                    }
                })
                .then(response => {
                    this.conversationPartners.unshift(response.data);
                })
                .catch(error => {
                    console.log(error);
                });
            }
            await this.selectConversation(receiverId);
            this.showMessageScreen = true;
        },
        selectConversation: async function (partnerId) {
            this.newMessage.ReceiverId = partnerId;
            const url = `${this.baseUrl}messages/conversation/${this.currentUserId}/${partnerId}`;
            this.messages = await axios.get(url, {
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
            this.showConversation = true;
        },
        sendMessage: async function () {
            this.newMessage.SenderId = this.currentUserId;
            const url = `${this.baseUrl}messages`;
            this.loading = true;
            await axios.post(url, this.newMessage, {
                headers: {
                    Authorization: `Bearer ${this.token}`
                }
            })
            .then(response => response.data)
            .catch(error => {
                console.log(error);
            });
            this.newMessage.Content = "";
            await this.selectConversation(this.newMessage.ReceiverId);
            this.loading = false;
        },
        showUserDetailsHandler: async function (userId) {
            this.userDetailsId = userId;
            const url = `${this.baseUrl}auth/${userId}`;
            this.loading = true;
            this.userDetails = await axios.get(url, {
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
            this.loading = false;
            this.showUserDetails = true;
        },
        addReview: async function () {
            const url = `${this.baseUrl}reviews`;
            this.newReview.ReviewerId = this.currentUserId;
            this.newReview.RevieweeId = this.userDetailsId;
            this.loading = true;
            await axios.post(url, this.newReview, {
                headers: {
                    Authorization: `Bearer ${this.token}`
                }
            })
            .then(response => {
                console.log(response.data);
                this.userDetails.reviews.push(response.data);
            })
            .catch(error => {
                console.log(error);
            });
            this.loading = false;
        },
        submitLogin: async function () {
            const loginDto = { "username": this.username, "password": this.password };
            this.loginError = "";
            this.loading = true;
            const token = await axios.post(`${this.baseUrl}auth/login`, loginDto)
                .then(response => response.data.token)
                .catch(error => {
                    console.log(error);
                    this.loginError = "Invalid username or password";
                    this.loading = false;
                });
            await this.setToken(token);
            window.sessionStorage.setItem('token', token);
            this.loading = false;
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
        submitLogout: function () {
            this.token = "";
            this.tokenObject = null;
            window.sessionStorage.clear();
            this.loggedIn = false;
            this.isEmployer = false;
            this.loggedInUsername = "";
            this.currentUserId = "";
            this.dropdownVisible = false;
            this.jobs = [];
            this.applications = [];
            this.selectedApplication = null;
            this.selectedJob = null;
            this.viewApplications = false;
            this.showMessageScreen = false;
            this.newMessage.SenderId = "";
            this.newMessage.ReceiverId = "";
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
        openDeleteModal: function () {
            this.isDeleting = true;
        },
        closeDeleteModal: function () {
            this.isDeleting = false;
            this.selectedJob = null;
            this.selectedApplication = null;
        },
    }
});
