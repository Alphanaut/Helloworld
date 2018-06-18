(function registrationServiceInit() {
    'use strict';

    function registrationService($resource, appSettings) {
        var registrationServicePath = /*appSettings.serverPath*/'http://localhost:82/' + 'api/registration';

        return {
            registration: $resource(registrationServicePath + '/:id', null, { 'update': { method: 'PUT' } }),
            options: {
                addressTypes: $resource(registrationServicePath + '/options/addressTypes'),
                stateCodes: $resource(registrationServicePath + '/options/states'),
                countryCodes: $resource(registrationServicePath + '/options/countries')
            }
        }
    }

    angular.module('app').factory('registrationService', ['$resource', 'appSettings', registrationService]);
}());