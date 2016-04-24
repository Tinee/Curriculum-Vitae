(function () {
   'use strict';

   angular
      .module('app.factories')
      .factory('popup', Popup);

   Popup.$inject = ['$ionicPopup'];
   function Popup($ionicPopup) {
      var services = {
         confirmPopup: confirmPopup
      };

      return services;

      ////////////////
      function confirmPopup(title, body) {
         return $ionicPopup.confirm({
            title: title,
            template: body
         });
      }
   }
})();