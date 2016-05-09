(function () {
   'use strict';

   angular
      .module('factories.module')
      .factory('courses', courses);

   courses.$inject = [];
   function courses() {
      var service = {
         get: get
      };

      return service;

      ////////////////
      function get() {
         return [
            {
               courseName: 'Molntjänst Utveckling',
               grade: 'VG'
            },
            {
               courseName: 'Programmering .NET',
               grade: 'VG'
            },
            {
               courseName: 'Sälj och Mangement',
               grade: 'VG'
            },
            {
               courseName: 'Sql och Databaser',
               grade: 'G'
            },
            {
               courseName: 'Webbutveckling',
               grade: 'VG'
            },
            {
               courseName: 'Examensarbete',
               grade: 'VG'
            },
            {
               courseName: 'Projektkunskap',
               grade: 'G'
            },
            {
               courseName: 'Lia 1',
               grade: 'VG'
            },

            {
               courseName: 'Lia 2',
               grade: 'VG'
            },


         ];
      }
   }
})();