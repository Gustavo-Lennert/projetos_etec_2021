import 'dart:convert';
import 'dart:math';

import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class HomePage extends StatefulWidget {
  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  List _items = [];

  String _cod = "Codigo Veículo: ";
  String _name = "Nome: ";
  String _descricao = "Descrição Detalhada: ";
  String _placas = "Placa ";
  String _marCarroA = "BMW";
  String _marCarroB = "Audi";
  String _marCarroC = "Dodge";
  String _marCarroD = "Fiat";
  String _marCarroE = "Ford";
  String _marCarroF = "Honda";
  String _marCarroG = "Porsche";
  String _marCarroH = "Nissan";
  String _marCarroI = "Jaguar";
  String _tipo = "abc";
  String _tipo1 = "def";
  String _tipo2 = "ghi";
  String _tipo3 = "jkl";
  String _tipo4 = "mno";
  String _tipo5 = "pqr";
  String _tipo6 = "stu";
  String _tipo7 = "vwx";
  String _tipo8 = "yzav";

  void _createItems() {
    _items = [];
    for (int i = 0; i < 30; i++) {
      if (i <= 2) {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroA;
        item["descrição"] =
            _descricao + _placas + _tipo + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      } else if (i <= 5) {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroB;
        item["descrição"] =
            _descricao + _placas + _tipo1 + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      } else if (i <= 8) {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroC;
        item["descrição"] =
            _descricao + _placas + _tipo2 + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      } else if (i <= 11) {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroD;
        item["descrição"] =
            _descricao + _placas + _tipo3 + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      } else if (i <= 14) {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroE;
        item["descrição"] =
            _descricao + _placas + _tipo4 + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      } else if (i <= 17) {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroF;
        item["descrição"] =
            _descricao + _placas + _tipo5 + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      } else if (i <= 20) {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroG;
        item["descrição"] =
            _descricao + _placas + _tipo6 + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      } else if (i <= 23) {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroH;
        item["descrição"] =
            _descricao + _placas + _tipo7 + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      } else {
        Map<String, dynamic> item = Map();
        item["codigo"] = i + 1;
        item["cod"] = _cod + (i + 1).toString();
        item["nome"] = _name + _marCarroI;
        item["descrição"] =
            _descricao + _placas + _tipo8 + Random().nextInt(100).toString();
        item["preco"] = Random().nextInt(30000).toString();
        item["qtdEstoque"] = Random().nextInt(100).toString();
        _items.add(item);
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    //_findItems();
    _createItems();
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.lightBlue,
        title: Text("Lista de Marcas de Carros"),
      ),
      body: Container(
        padding: EdgeInsets.all(10),
        child: ListView.builder(
          itemCount: _items.length,
          itemBuilder: (context, index) {
            return ListTile(
              onTap: () {
                showDialog(
                  context: context,
                  builder: (context) {
                    return AlertDialog(
                      title: Text('Detalhes do Carro'),
                      titlePadding: EdgeInsets.all(20),
                      titleTextStyle: TextStyle(
                        fontSize: 25,
                        color: Colors.lightBlue,
                      ),
                      content: SingleChildScrollView(
                        child: ListBody(
                          children: <Widget>[
                            Text(_items[index]["cod"].toString()),
                            Text(_items[index]["nome"].toString()),
                            Text(_items[index]["descrição"].toString()),
                            Text('Preço: ${_items[index]["preco"].toString()}'),
                            Text(
                              'Armazém: ${_items[index]["qtdEstoque"].toString()}',
                            ),
                          ],
                        ),
                      ),
                      actions: [
                        FlatButton(
                          onPressed: () {
                            Navigator.pop(context);
                          },
                          child: Text("Fechar"),
                        )
                      ],
                    );
                  },
                );
              },
              title: Text(_items[index]["cod"].toString()),
              subtitle: Text(
                'Armazém: ${_items[index]["qtdEstoque"].toString()}',
              ),
            );
          },
        ),
      ),
    );
  }
}
