(function registrationEditCtrlInit() {
    'use strict';

    function registrationEditCtrl($state, $stateParams, registrationService) {
        var self = this,
            registrationId = $stateParams.id ? $stateParams.id : "00000000-0000-0000-0000-000000000000", // TODO: replace with const from config file; *NB. we do not currently implement "update"
            isNew = registrationId === "00000000-0000-0000-0000-000000000000" ? true : false;

        function getRegistration() {

            registrationService.registration.get({}).$promise.then(function (registration) {
                self.registration = registration;
                getAddressTypeOptions();
                getStateCodeOptions();
                getCountryCodeOptions();
            })
                .catch(function (/*error*/) {
                    toastr.error('there was a problem loading the registration form.');
                });
        }

        function getAddressTypeOptions() {
            registrationService.options.addressTypes.query().$promise.then(function (addressTypes) {
                if (!addressTypes || addressTypes.length === 0) {
                    throw 'there are no addressTypes to apply';
                }

                self.addressTypes = addressTypes;
            })
                .catch(function (/*error*/) {
                    toastr.error('there was a problem getting address type options');
                });
        }

        function getStateCodeOptions() {
            registrationService.options.stateCodes.query().$promise.then(function (stateCodes) {
                if (!stateCodes || stateCodes.length === 0) {
                    throw 'there are no stateCodes to apply';
                }

                self.stateCodes = stateCodes;
            })
                .catch(function (/*error*/) {
                    toastr.error('there was a problem getting stateCode options');
                });
        }

        function getCountryCodeOptions() {
            registrationService.options.countryCodes.query().$promise.then(function (countryCodes) {
                if (!countryCodes || countryCodes.length === 0) {
                    throw 'there are no countryCodes to apply';
                }

                self.countryCodes = countryCodes;
            })
                .catch(function (/*error*/) {
                    toastr.error('there was a problem getting countryCode options');
                });
        }

        function cleanForm() {
            self.registration = {
            id: registrationId,
            firstName : '',
            lastName : '',
            street1 : '',
            city1 : '',
            stateId1 : '1',
            zipCode1 : '',
            countryId1 : '1',
            street1 : '',
            city1 : '',
            stateId1 : '1',
            zipCode2 : '',
            countryId1 : '1',
            }   
            
            self.formSubmitted = false;
        }

        function reloadForm() {
            cleanForm();
            $state.go('register');
        }

        
        self.formSubmitted = false;

        self.cancel = function () {
            reloadForm();
        }

        self.submit = function submitRequeset(isValid) {
            if (isValid) {
                self.formSubmitted = true;

                if (isNew) {
                    registrationService.registration.save(self.registration).$promise.then(function (/*response*/) {
                        toastr.success('registration submitted successfully');
                        $state.go('result');
                    })
                        .catch(function (/*error*/) {
                            toastr.error('there was a problem submitting the registration');
                            //cleanForm();
                    });
                }
                
            }         
        }

        getRegistration();
    }

    angular.module('app').controller('RegistrationEditCtrl', ['$state', '$stateParams', 'registrationService', registrationEditCtrl]);
}());