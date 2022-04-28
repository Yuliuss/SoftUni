function solve(arr){
    arr.sort((a,b) => a-b);
    let resultArr = [];

    while(arr.length > 0){
        resultArr.push(arr.shift());
        if (arr.length !== 0){
            resultArr.push(arr.pop());
        }
    }

    return resultArr;
}