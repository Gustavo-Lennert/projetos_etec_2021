import 'package:flutter/material.dart';
import 'package:tarefa_clima_tempo/controllers/tema_control.dart';
import 'home.dart';

class Clima extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return AnimatedBuilder(
      animation: TemaController.instancia,
      builder: (context, child) {
        return MaterialApp(
          title: 'Clima',
          theme: TemaController.instancia.temaEscuro
            ? ThemeData.dark()
            : ThemeData.light(),
          debugShowCheckedModeBanner: false,
          home: Home(),
        );
      },
    );
  }
}
