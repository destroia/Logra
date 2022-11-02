import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BarVideoComponent } from './bar-video.component';

describe('BarVideoComponent', () => {
  let component: BarVideoComponent;
  let fixture: ComponentFixture<BarVideoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BarVideoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BarVideoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
