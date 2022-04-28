function solve(inputArr){
    let obj = {};
    for (let index = 0; index < inputArr.length; index+= 2){
        let key = inputArr[index];
        obj[key] = Number(inputArr[index + 1]);
    }

    return obj;
}