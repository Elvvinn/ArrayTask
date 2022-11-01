var object = [
    {
        brand: "bmw",
        model: "f30",
        color: "blue",
        year: "2018"

    },
    {

        brand: "mercedes",
        model: "e190",
        color: "silver",
        year: "2000"

    },
    {
        brand: "toyota",
        model: "hybrid",
        color: "white",
        year: "2015",
    },
    {

        brand: "SsangYong",
        model: "Kayron",
        color: "black",
        year: "2007"
    },
    {

        brand: "kia",
        model: "rio",
        color: "green",
        year: "2008"

    }

]

for (let i = 0; i < object.length; i++) {

    if (object[i].year > 2010) {
        console.log(object[i].brand);
    }
}

