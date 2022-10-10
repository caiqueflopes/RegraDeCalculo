import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-negociacao',
  templateUrl: './negociacao.component.html',
  styleUrls: ['./negociacao.component.css']
})
export class NegociacaoProfileComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  public NumeroContrato='101010';
  public NomeUser='Caique Lopes';
  public ValorContrato='110,55';
  public DataVencCont='01/03/2019';
  
}
