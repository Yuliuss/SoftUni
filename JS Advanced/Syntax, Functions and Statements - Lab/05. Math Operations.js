function solve(x, y, operator){
    let result;
    if (operator === '+'){
        result = x + y;
    }
    else if (operator === '-'){
        result = x - y;
    }
    else if (operator === '*'){
        result = x * y;
    }
    else if (operator === '/'){
        result = x / y;
    }
    else if (operator === '%'){
        result = x % y;
    }else if (operator === '**'){
        result = x ** y;
    }
    console.log(result);
}