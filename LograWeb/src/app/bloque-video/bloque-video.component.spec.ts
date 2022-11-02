import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BloqueVideoComponent } from './bloque-video.component';

describe('BloqueVideoComponent', () => {
  let component: BloqueVideoComponent;
  let fixture: ComponentFixture<BloqueVideoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BloqueVideoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BloqueVideoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
