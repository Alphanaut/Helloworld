(function registrationListCtrlInit() {
    'use strict';

    function registrationListCtrl() {
        var self = this;

        self.title = 'these are words';
        self.registrants = [
            {
                "firstName": "Bill",
                "lastName": "Baker",
                "city": "Detroit",
                "state": "MI",
                "country": "USA",
                "createdDate": "5/5/2018"
            },
            {
                "firstName": "Anibal",
                "lastName": "Tester",
                "city": "Denver",
                "state": "CO",
                "country": "USA",
                "createdDate": "5/6/2018"
            },
            {
                "firstName": "Steve",
                "lastName": "Jackson",
                "city": "Boston",
                "state": "MA",
                "country": "UAS",
                "createdDate": "3/8/2018"
            },
            {
                "firstName": "Brock",
                "lastName": "Sampson",
                "city": "Las Vegas",
                "state": "NV",
                "country": "USA",
                "createdDate": "7/7/2017"
            }
        ];
    }

    angular.module('app').controller('RegistrationListCtrl', [registrationListCtrl]);
}());