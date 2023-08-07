var lawyers = new []
{
    new Lawyer()
    {
        FirstName = "John",
        LastName = "Doe",
    }
    new Lawyer()
    {
        FirstName = "Ade",
        LastName = "Mouser",
    }
};

var clients = new{}
{
    new Client()
    {
        FirstName = "Sarah",
        LastName = "Somethingdumb",
    }
    new Client()
    {
        FirstName = "Jim",
        LastName = "Decker",
    }
    new Client()
    {
        FirstName = "Yana",
        LastName = "Ket",
    }
};

var cases = new[]
{
    new Case()
    {
        Title = "Case title like Car Accident",
        AmountInDispute = 10000,
        CaseType = CaseType.Commercial,
        Client = clients[0],
        Lawyer = lawyers[0]
    },
    new Case()
    {
        Title = "Moldy Apartment",
        AmountInDispute = 65000,
        CaseType = CaseType.ProBono,
        Client = clients[0],
        Lawyer = lawyers[0]
    },
    new Case()
    {
        Title = "Death Threat",
        AmountInDispute = 15000,
        CaseType = CaseType.Commercial,
        Client = clients[1],
        Lawyer = lawyers[1]
    },
    new Case()
    {
        Title = "Robbery, Necklace",
        AmountInDispute = 1500,
        CaseType = CaseType.Commercial,
        Client = clients[2],
        Lawyer = lawyers[1]
    },
}