// See https://aka.ms/new-console-template for more information

using Session_07;

ActionRequest request = new ActionRequest()
{
    Input = "Fotis",
    Action = ActionEnum.Reverse
};

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);

// DISPLAY MESSAGES FROM LOGGER

resolver.Logger.ReadAll();

Console.ReadLine();