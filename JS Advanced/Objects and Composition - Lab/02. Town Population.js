function townPopulation(townsArr){
    const towns = {};
    for (let townAsString of townsArr){
        let [name, population] = townAsString.split(' <-> ');
        population = Number(population);

        if (town[name] != undefined) { population += towns[name];}
            town[name] = population;
    }
    for (let town in towns){
        console.log(`${town} : ${towns[town]}`);
    }
}