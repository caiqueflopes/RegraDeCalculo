import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NegociacaoProfileComponent } from './negociacao.component';

describe('NegociacaoProfileComponent', () => {
  let component: NegociacaoProfileComponent;
  let fixture: ComponentFixture<NegociacaoProfileComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NegociacaoProfileComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NegociacaoProfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
