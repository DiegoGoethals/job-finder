var app = new Vue({
    el: "#app",
    name: "app",
    data: {
        baseUrl: "https://localhost:44382/api/",
        username: "",
        password: "",
        token: "",
        emailAdress: "",
        dateOfBirth: new Date().toLocaleDateString("nl-BE"),
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
        isEmployer: false
    },
    created: function () {
        if (localStorage.getItem('token') !== null) {
            this.tokenObject = this.decodeToken(window.localStorage.getItem('token'));
            //get the emailadress
            this.emailAdress = this.tokenObject["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"];
            //get the role and store in sessionStorage
            const role = this.tokenObject["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
            if (role === "Employer") {
               this.isEmployer = true;
            }
            this.loggedIn = true;
            this.getSkills();
            this.getJobs();
            this.getMessages();
            this.getReviews();
            this.getApplications();
        }
    },
    methods: {
        getSkills: async function () {
            const url = `${this.baseUrl}skills`;
            console.log(url);
            this.skills = await axios.get(url)
                .then(response => {
                    console.log(response.data.skills);
                    return response.data.skills;
                })
                .catch(error => {
                    console.log(error);
                });
        },
        getJobs: async function () {
            const url = `${this.baseUrl}jobs`;
            console.log(url);
            this.jobs = await axios.get(url)
                .then(response => {
                    console.log(response.data.jobs);
                    return response.data.jobs;
                })
                .catch(error => {
                    console.log(error);
                });
        },
        decodeToken: function (token) {
            var base64Url = token.split('.')[1];
            var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            var jsonPayload = decodeURIComponent(window.atob(base64).split('').map(function (c) {
                return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
            }).join(''));
            return JSON.parse(jsonPayload);
        }
    }
});


