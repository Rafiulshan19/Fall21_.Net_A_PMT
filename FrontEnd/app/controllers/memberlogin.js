


app.controller('memberlogin', function($scope,$location) {
    $scope.submit = function(){
        var email=$scope.email;
        var password =$scope.password;
        if($scope.email =='jon@gmail.com' && $scope.password == '12345'){
            $location.path('views/pages/dashboard.html');
        }else{
            alert('Somethings Wrong');
        }
    }
});
