var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/supervisorlogin", {
        templateUrl : "views/pages/SupervisorLogin.html",
          controller: 'supervisorlogin'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/memberlogin", {
        templateUrl : "views/pages/MemberLogin.html",
        controller: 'memberlogin'
    })
    .when("/dashboard", {
        templateUrl : "views/pages/dashboard.html",
        
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
