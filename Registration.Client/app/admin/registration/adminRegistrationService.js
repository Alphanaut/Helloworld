(function adminRegistrationServiceInit() {
    'use strict';

    function adminRegistrationService($resource, appSettings) {
        var adminRegistrationServicePath = /*appSettings.serverPath*/'http://localhost:82/' + 'api/registration';

        return {
            registrant: $resource(adminRegistrationServicePath + '/admin/listing/:id', null, { 'update': { method: 'PUT' } })
        };
    }

    angular.module('app')
        .factory('adminRegistrationService', [
            '$resource',
            'appSettings',
            adminRegistrationService]);
}());