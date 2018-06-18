(function registrationEditCtrlInit() {
    'use strict';

    function registrationEditCtrl(registrationService) {
        var self = this;

        self.countryCodes = registrationService.getCountryCodes();
        self.stateCodes = registrationService.getStateCodes();
        self.addressTypes = registrationService.getAddressTypes();

        self.registration.stateId1 = self.stateCodes[0].value;
        self.registration.countryId1 = self.countryCodes[0].value;
        self.registration.addressTypeId1 = screen.addressTypes[0].value;

        vm.registration.stateId2 = self.stateCodes[0].value;
        self.registration.countryId2 = self.countryCodes[0].value;
        self.registration.addressTypeId2 = screen.addressTypes[0].value;
    }

    angular.module('app').controller('RegistrationEditCtrl', ['registrationService', registrationEditCtrl]);
}());