using System;

public class PingUseCaseSuperApp : IPingUseCase {

	public PongResponse Execute () {
		return new PongResponse {
			LadoMesa = "Direito"
		};
	}
}