import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BloqueDocComponent } from './bloque-doc.component';

describe('BloqueDocComponent', () => {
  let component: BloqueDocComponent;
  let fixture: ComponentFixture<BloqueDocComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BloqueDocComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BloqueDocComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
