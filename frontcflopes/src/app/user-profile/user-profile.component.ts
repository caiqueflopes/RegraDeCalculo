import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})
export class UserProfileComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  public NomeCompletoUser='Caique Lopes';
  public TelefoneUser='18998246134';
  public EnderecoUser='Ribeirão Preto, 460';
  public CidadeUser='Marilia';
  public EstadoUser='SP';
  public CepUser='17510-190';
}
