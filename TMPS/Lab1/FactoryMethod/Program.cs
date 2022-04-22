using FactoryMethod;

Dancer dancer;
Dance dance;

string dancerDress = "tutu";

switch (dancerDress)
{
    case "tutu":
        dancer = new Ballerina();
        break;

    case "everyday":
        dancer = new BreakDancer();
        break;

    default:
        dancer = new UnknownDancer();
        break;
}

dance = dancer.Dance();