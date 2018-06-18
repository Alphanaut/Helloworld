(function appInit() {
    'use strict';

    angular.module('app',
        [
            'ui.router',
            'ui.bootstrap',
            'ngResource',
            'ngSanitize'
        ]);

    //app.config([
    //    '$stateProvider', '$urlRouterProvider', function ($stateProvider) {
    //        $urlRouterProvider.otherwise('/register');

    //        $stateProvider
    //            .state('register', {
    //                    url: '/register',
    //                    templateUrl: 'app/registration/edit/registrationEditTemplate.html',
    //                    controller: 'RegistrationEditCtrl',
    //                    controllerAs: 'vm'
    //                });
    //    }
    //]);
}());