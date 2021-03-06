function imutabilidade()
{
    const imutableVariable = 3

    const pureFunction = number => number + 2

    const otherImutableVariable = pureFunction(imutableVariable)

    console.log(number) // number is not defined
    console.log(imutableVariable) // 3
    console.log(otherImutableVariable) // 5
}
