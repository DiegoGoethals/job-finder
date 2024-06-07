﻿var app = new Vue({
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
        newApplication: {
            JobId: "",
            CandidateId: "",
            Salary: 0
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
    },
    created: function () {
        if (localStorage.getItem('token') !== null) {
            this.token = localStorage.getItem('token');
            this.tokenObject = this.decodeToken(window.localStorage.getItem('token'));
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
    }
});


