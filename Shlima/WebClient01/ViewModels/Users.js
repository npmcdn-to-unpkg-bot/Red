$(document).ready(function () {

    function usersViewModel() {

        var self = this;

        self.mode = ko.observable(0);
        self.modeIsList = ko.computed(function () {
            return self.mode() === 0;
        });
        self.modeIsDisplay = ko.computed(function () {
            return self.mode() === 1;
        });
        self.modeIsCreate = ko.computed(function () {
            return self.mode() === 2;
        });
        self.modeIsUpdate = ko.computed(function () {
            return self.mode() === 3;
        });
        self.modeIsDelete = ko.computed(function () {
            return self.mode() === 4;
        });

        self.users = ko.observableArray();
        self.user = ko.observable();

        //view model method (refresh)
        self.refresh = function () {
            $.getJSON("http://localhost/WebApi01/users", function (data) {
                self.users.removeAll();
                self.user(null);
                for (var i = 0; i < data.Users.length; i++) {
                    self.users.push({

                        //list properties
                        id: data.Users[i].Id,
                        email: data.Users[i].Email,
                        userName: data.Users[i].UserName,

                        //list method (display)
                        display: function () {

                            $.getJSON("http://localhost/WebApi01/users/" + this.id, function (data) {
                                self.user({

                                    //display properties
                                    id: data.User.Id,
                                    email: data.User.Email,
                                    emailConfirmed: data.User.EmailConfirmed,
                                    passwordHash: data.User.PasswordHash,
                                    securityStamp: data.User.SecurityStamp,
                                    phoneNumber: data.User.PhoneNumber,
                                    phoneNumberConfirmed: data.User.PhoneNumberConfirmed ? "Yes" : "No",
                                    twoFactorEnabled: data.User.TwoFactorEnabled ? "Yes" : "No",
                                    lockoutEndDateUtc: data.User.LockoutEndDateUtc,
                                    lockoutEnabled: data.User.LockoutEnabled ? "Yes" : "No",
                                    accessFailedCount: data.User.AccessFailedCount,
                                    userName: data.User.UserName,

                                    //display method (cancel)
                                    cancel: function () {
                                        self.user(null);
                                        self.mode(0);
                                    }
                                });
                            });

                            self.mode(1);
                        },

                        //list method (update)
                        update: function () {
                            self.user({

                                //update properties
                                id: this.id,
                                email: ko.observable(this.email),
                                userName: ko.observable(this.userName),

                                //update method (cancel)
                                cancel: function () {
                                    self.user(null);
                                    self.mode(0);
                                },

                                //update method (commit)
                                commit: function () {
                                    $.ajax({
                                        url: "http://localhost/WebApi01/users/" + this.id,
                                        type: 'PUT',
                                        data:
                                        {
                                            User:
                                            {
                                                Id: this.id,
                                                Email: this.email(),
                                                UserName: this.userName()
                                            }
                                        }
                                    }).done(function () {
                                        self.refresh();
                                        self.mode(0);
                                    });
                                }
                            });
                            self.mode(3);
                        },

                        delete_: function () {
                            self.user({

                                //delete properties
                                id: this.id,
                                email: this.email,
                                userName: this.userName,

                                //delete method (cancel)
                                cancel: function () {
                                    self.user(null);
                                    self.mode(0);
                                },

                                //delete method (commit)
                                commit: function () {
                                    $.ajax({
                                        url: "http://localhost/WebApi01/users/" + this.id,
                                        type: 'DELETE'
                                    }).done(function () {
                                        self.refresh();
                                        self.mode(0);
                                    });
                                }
                            });
                            self.mode(4);
                        }
                    });
                }
            });
        };

        //view model method (create)
        self.create = function () {
            self.user({

                //create properties
                email: ko.observable(""),
                userName: ko.observable(""),

                //create method (cancel)
                cancel: function () {
                    self.user(null);
                    self.mode(0);
                },

                //create method (commit)
                commit: function () {
                    $.ajax({
                        url: "http://localhost/WebApi01/users",
                        type: 'POST',
                        data:
                            {
                                User:
                                    {
                                        Email: this.email(),
                                        UserName: this.userName()
                                    }
                            }
                    }).done(function () {
                        self.refresh();
                        self.mode(0);
                    });
                }
            });
            self.mode(2);
        };

        self.refresh();
    }

    ko.applyBindings(new usersViewModel());

});
