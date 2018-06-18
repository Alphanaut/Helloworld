(function registrationServiceInit() {
    'use strict';

    function registrationService() {
        function getCountryCodes() {
            var data = [];

            data.push({ id: '1', name: 'United States', countryCode: 'USA' });

            return data;
        }

        function getAddressTypes() {
            var data = [];

            data.push({ Name: "Address 1", Description: "Address 1", Position: '1' });
            data.push({ Name: "Address 2", Description: "Address 2", Position: '2' });

            return data;
        }

        function getStateCodes() {
            var data = [];

            data.push({ USPSCode: "AL", Name: "Alabama", Position: 1 });
            data.push({ USPSCode: "AK", Name: "Alaska", Position: 2 });
            data.push({ USPSCode: "AZ", Name: "Arizona", Position: 3 });
            data.push({ USPSCode: "AR", Name: "Arkansas", Position: 4 });
            data.push({ USPSCode: "CA", Name: "California", Position: 5 });
            data.push({ USPSCode: "CO", Name: "Colorado", Position: 6 });
            data.push({ USPSCode: "CT", Name: "Connecticut", Position: 7 });
            data.push({ USPSCode: "DE", Name: "Delaware", Position: 8 });
            data.push({ USPSCode: "DC", Name: "District of Columbia", Position: 9 });
            data.push({ USPSCode: "FL", Name: "Florida", Position: 10 });
            data.push({ USPSCode: "GA", Name: "Georgia", Position: 11 });
            data.push({ USPSCode: "HI", Name: "Hawaii", Position: 12 });
            data.push({ USPSCode: "ID", Name: "Idaho", Position: 13 });
            data.push({ USPSCode: "IL", Name: "Illinois", Position: 14 });
            data.push({ USPSCode: "IN", Name: "Indiana", Position: 15 });
            data.push({ USPSCode: "IA", Name: "Iowa", Position: 16 });
            data.push({ USPSCode: "KS", Name: "Kansas", Position: 17 });
            data.push({ USPSCode: "KY", Name: "Kentucky", Position: 18 });
            data.push({ USPSCode: "LA", Name: "Louisiana", Position: 19 });
            data.push({ USPSCode: "ME", Name: "Maine", Position: 20 });
            data.push({ USPSCode: "MD", Name: "Maryland", Position: 21 });
            data.push({ USPSCode: "MA", Name: "Massachusetts", Position: 22 });
            data.push({ USPSCode: "MI", Name: "Michigan", Position: 23 });
            data.push({ USPSCode: "MN", Name: "Minnesota", Position: 24 });
            data.push({ USPSCode: "MS", Name: "Mississippi", Position: 25 });
            data.push({ USPSCode: "MO", Name: "Missouri", Position: 26 });
            data.push({ USPSCode: "MT", Name: "Montana", Position: 27 });
            data.push({ USPSCode: "NE", Name: "Nebraska", Position: 28 });
            data.push({ USPSCode: "NV", Name: "Nevada", Position: 29 });
            data.push({ USPSCode: "NH", Name: "New Hampshire", Position: 30 });
            data.push({ USPSCode: "NJ", Name: "New Jersey", Position: 31 });
            data.push({ USPSCode: "NM", Name: "New Mexico", Position: 32 });
            data.push({ USPSCode: "NY", Name: "New York", Position: 33 });
            data.push({ USPSCode: "NC", Name: "North Carolina", Position: 34 });
            data.push({ USPSCode: "ND", Name: "North Dakota", Position: 35 });
            data.push({ USPSCode: "OH", Name: "Ohio", Position: 36 });
            data.push({ USPSCode: "OK", Name: "Oklahoma", Position: 37 });
            data.push({ USPSCode: "OR", Name: "Oregon", Position: 38 });
            data.push({ USPSCode: "PA", Name: "Pennsylvania", Position: 39 });
            data.push({ USPSCode: "RI", Name: "Rhode Island", Position: 40 });
            data.push({ USPSCode: "SC", Name: "South Carolina", Position: 41 });
            data.push({ USPSCode: "SD", Name: "South Dakota", Position: 42 });
            data.push({ USPSCode: "TN", Name: "Tennessee", Position: 43 });
            data.push({ USPSCode: "TX", Name: "Texas", Position: 44 });
            data.push({ USPSCode: "UT", Name: "Utah", Position: 45 });
            data.push({ USPSCode: "VT", Name: "Vermont", Position: 46 });
            data.push({ USPSCode: "VA", Name: "Virginia", Position: 47 });
            data.push({ USPSCode: "WA", Name: "Washington", Position: 48 });
            data.push({ USPSCode: "WV", Name: "West Virginia", Position: 49 });
            data.push({ USPSCode: "WI", Name: "Wisconsin", Position: 50 });
            data.push({ USPSCode: "WY", Name: "Wyoming", Position: 51 });

            return data;
        }

        return {
            getCountryCodes: getCountryCodes,
            getAddressTypes: getAddressTypes,
            getStateCodes: getStateCodes
        }
    }

    angular.module('app').factory('registrationService', [registrationService]);
}());