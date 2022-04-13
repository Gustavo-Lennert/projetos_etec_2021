import 'package:flutter/material.dart';
import 'package:tarefa_clima_tempo/models/hora_clima.dart';
import 'package:tarefa_clima_tempo/services/clima_service.dart';
import 'package:tarefa_clima_tempo/widgets/proximas_temp.dart';
import 'resumo.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  List<ClimaHora> ultimasPrevisoes;


  /*
    API do sistema:
    "GET /forecasts/v1/hourly/12hour/1-41595_1_AL?apikey=e3tK2WmN3m6CWKwkT5DqWts6VXaeFtbK&language=pt-BR&metric=true HTTP/1.1";
  */

  @override
  void initState() {
    super.initState();
    ClimaService service = ClimaService();
    ultimasPrevisoes = service.recuperarUltimasPrevisoes();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Clima'),
        centerTitle: true,
      ),
      body: Center(
        child: Column(
          children: [
            Resumo(
              cidade: 'Áruja-SP',
              temperaturaAtual: 15,
              temperaturaMaxima: 21,
              temperaturaMinima: 12,
              descricao: 'Ensolarado',
              numeroIcone: 1,
            ),
            Padding(padding: EdgeInsets.all(10)),
            ProximasTemp(
              previsoes: ultimasPrevisoes,
            )
          ],
        ),
      ),
    );
  }
}
