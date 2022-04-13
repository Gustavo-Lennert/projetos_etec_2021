import 'package:flutter/material.dart';

class TemaController extends ChangeNotifier {
  bool temaEscuro;
  static TemaController instancia = new TemaController();

  TemaController() {
    temaEscuro = false;
  }

  trocarTema() {
    temaEscuro = !temaEscuro;
    notifyListeners();
  }
}
