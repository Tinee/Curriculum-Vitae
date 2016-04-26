(function() {
   'use strict';

   angular.module('app.core').config(blockUiConfig);


   blockUiConfig.$inject = ['blockUIConfig']
   function blockUiConfig(blockUIConfig) {
            blockUIConfig.message = 'Hämtar personliga brevet...';
            blockUIConfig.autoBlock = false;
   }
})();