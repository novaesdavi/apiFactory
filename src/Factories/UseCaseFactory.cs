//create an implementation of the IUseCaseFactory interface
// Path: src/Factories/UseCasefactory.cs
// Compare this snippet from src/Factories/UseCasefactory.cs:
using System;

public class UseCaseFactory : IUseCaseFactory {

    public IPingUseCase GetUseCase (string apiKey, string tipoProduto) {
        switch (apiKey) {
            case "ION":
                if (tipoProduto == "Ping")
                    return new PingUseCaseIon ();
                else
                    throw new ArgumentException ("tipoProduto inválido");
            case "SuperApp":
                if (tipoProduto == "Ping")
                    return new PingUseCaseSuperApp ();
                else
                    throw new ArgumentException ("tipoProduto inválido");
            default:
                throw new ArgumentException ("ApiKey inválido");
        }
    }
}