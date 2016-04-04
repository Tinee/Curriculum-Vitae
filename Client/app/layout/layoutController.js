(function() {
'use strict';

   angular
      .module('layout.module')
      .controller('LayoutController', LayoutController);

   LayoutController.$inject = ['levelbar','dataservice'];
   function LayoutController(levelbar,dataservice) {
      var vm = this;
      

      activate();

      ////////////////

      function activate() {
         levelbar.getValues();
       }
   }
})();