function solve(inputArr, step){
    let resultArr = [];
    for (let index = 0; index < inputArr.length; index+= step){
        resultArr.push(inputArr[index]);
    }
    return resultArr;
}