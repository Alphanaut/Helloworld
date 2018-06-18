(function adminRegistrationListCtrlInit() {
    'use strict';

    function adminRegistrationListCtrl($filter, adminRegistrationService) {
        var self = this;

        self.title = 'Admin Registrant Listing';

        function getRegistrantList() {
            // TODO: add sorting
            // TODO: add paging
            // TODO: add loader gif
           

            adminRegistrationService.registrant.query().$promise.then(function (data) {
                    self.registrants = data;
                })
                .catch(function (/*error*/) {
                    toastr.error('there was a problem getting the registration list');
                });
        }

        getRegistrantList();
    }

    angular.module('app').controller('AdminRegistrationListCtrl', ['$filter','adminRegistrationService', adminRegistrationListCtrl]);
}());

/*
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
*/