import 'package:tarefa_clima_tempo/models/hora_clima.dart';

class ClimaService {
  List<ClimaHora> recuperarUltimasPrevisoes() {
    return [
      ClimaHora('11:00', 'Ensolarado', 1, 32),
      ClimaHora('12:00', 'Ensolarado', 1, 32),
      ClimaHora('13:00', 'Ensolarado', 1, 33),
      ClimaHora('14:00', 'Ensolarado', 1, 34),
      ClimaHora('15:00', 'Ensolarado', 1, 35),
      ClimaHora('16:00', 'Ensolarado', 1, 34),
      ClimaHora('17:00', 'Parcialmente ensolarado', 1, 32),
      ClimaHora('18:00', 'Nuvens esparsas', 3, 29),
      ClimaHora('19:00', 'Nuvens esparsas', 3, 26),
      ClimaHora('20:00', 'Nuvens esparsas', 3, 25),
    ];
  }
}
