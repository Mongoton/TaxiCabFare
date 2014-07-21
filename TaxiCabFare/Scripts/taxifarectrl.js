app.controller("MainController", function ($scope, $http) {
    $scope.calculate = function (ride) {
        var result = $http.post("/Home/Index/", ride);
        //alert("heretest1");
        result.success(function (data) {
            //alert("heretest2");
            $scope.totalfare = "The total fare is: " + data.result;
            //alert("heretest3");
        });
        //alert('hiho');
    };
    //$scope.message = 'blah';
    //        calculate.get().then(function (rideInfo) { $scope.rideInfo = rideInfo });
    //$scope.calculate = function (ride) {
    //};
});
