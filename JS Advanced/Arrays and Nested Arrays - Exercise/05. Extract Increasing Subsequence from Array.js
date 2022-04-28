function solve(input) {
    let inputChecker = [];
    for(let i = 0; i<input.length; i++){
        if(input[i]){
            inputChecker.push(input[i]);
        }
    }
    inputChecker = inputChecker.map(Number);
    let output = [];
    output.push(inputChecker[0]);
    for(let i = 1; i < inputChecker.length; i++){
        if(inputChecker[i] >= output[output.length-1]){
            output.push(inputChecker[i]);
        }
    }
    for(let element of output){
        console.log(element);
    }
}