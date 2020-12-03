function sockMerchant(n, ar) {
    let data = ar.reduce((a, b) => {
        if (!a.hasOwnProperty(b)) {
            a[b] = 1;
        } else {
            a[b]++;
        }
        return a;
    }, {})
    return Object.values(data).reduce((a, b) => a + Math.floor(b / 2), 0)
}

console.log(sockMerchant(9, [
    10, 20, 20, 10, 10, 30, 50, 10, 20]));  