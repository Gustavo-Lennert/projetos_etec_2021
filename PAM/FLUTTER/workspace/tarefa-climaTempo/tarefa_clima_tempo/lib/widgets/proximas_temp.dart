import 'package:flutter/material.dart';
import 'package:tarefa_clima_tempo/models/hora_clima.dart';

class ProximasTemp extends StatelessWidget {
  final List<ClimaHora> previsoes;

  const ProximasTemp({Key key, this.previsoes}) : super(key: key);

  Card cardPrevisao(int i) {
    return Card(
      child: Row(
      mainAxisAlignment: MainAxisAlignment.start,
      children: [
        Image(image: AssetImage('images/${previsoes[i].numeroIcon}.png')),
        Padding(padding: EdgeInsets.all(2)),
        Text(previsoes[i].horario),
        Padding(padding: EdgeInsets.all(5)),
        Text('${previsoes[i].temperatura.toStringAsFixed(0)}ºC'),
        Padding(padding: EdgeInsets.all(5)),
        Text(previsoes[i].descricao),
        Padding(padding: EdgeInsets.all(5)),
      ],
    ));
  }

  @override
  Widget build(BuildContext context) {
    return Expanded(
      child: ListView.builder(
        itemCount: previsoes.length,
        shrinkWrap: true,
        itemBuilder: (context, i) {
          return cardPrevisao(i);
        },
      ),
    );
  }
}
