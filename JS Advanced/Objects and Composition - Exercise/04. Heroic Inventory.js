function solve(inputArr){
    let heroesArr = [];
    for (let index = 0; index < inputArr.length; index++) {
        let [name, level, items] = inputArr[index].split(' / ')
        level = Number(level);
        items = items !== undefined ? items.split(', ') : [];

        heroesArr.push({name: name, level: level, items: items});

    }

    return JSON.stringify(heroesArr);
}