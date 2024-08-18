import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DigitValidationComponent } from './digit-validation.component';

describe('DigitValidationComponent', () => {
  let component: DigitValidationComponent;
  let fixture: ComponentFixture<DigitValidationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DigitValidationComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DigitValidationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
