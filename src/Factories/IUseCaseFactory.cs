using System;
using System.Runtime.CompilerServices;

public interface IUseCaseFactory {
    IPingUseCase GetUseCase (string apiKey, string tipoProduto);
}