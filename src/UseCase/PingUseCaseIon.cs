using System;

public class PingUseCaseIon : IPingUseCase {

	public PongResponse Execute () {
		return new PongResponse {
			LadoMesa = "Esquerdo"
		};
	}
}