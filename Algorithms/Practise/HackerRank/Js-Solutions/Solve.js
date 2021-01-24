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

function rotLeft(a, d) {

    let index = 0;
    let splicedArray;
    let result;

    if(d > a.length){
        index = d % a.length;
        let currentIndex = a.length -index-1;
        splicedArray = a.splice(0,a.length - currentIndex-1);
         result = a.concat(splicedArray);
        return result;
    }
         splicedArray = a.splice(0,d);
         result = a.concat(splicedArray);
        return result;



   

}
// console.log(sockMerchant(9, [
//     10, 20, 20, 10, 10, 30, 50, 10, 20]));  
    console.log(rotLeft([1,2,3,4,5],4));