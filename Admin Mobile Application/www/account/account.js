(function () {
    'use strict';

    angular
        .module('app.account')
        .controller('AccountController', AccountController);

    AccountController.$inject = ['$state'];
    function AccountController($state) {
        var vm = this;


        activate();

        vm.logout = logout;

        ////////////////

        function activate() { }

        function logout() {
            window.localStorage.removeItem('token');
            $state.go('tab.login');
        }
    }
})();