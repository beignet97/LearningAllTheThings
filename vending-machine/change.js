function getChange(totalPayable, cashPaid) {
    var change = [];
    var coins = [200, 100, 50, 20, 10, 5, 2, 1];
    var changeLeft = cashPaid - totalPayable;

    while (changeLeft > 0) {
        for (var i = 0; i < coins.length; i++) {
            var coin = coins[i];

            if (changeLeft >= coin) {
                change.push(coin);
                changeLeft -= coin;

                break;
            }
        }
    }

    return change;
};