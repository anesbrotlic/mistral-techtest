import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MovieTabComponent } from './movie-tab.component';

describe('MovieTvshowTabComponent', () => {
  let component: MovieTabComponent;
  let fixture: ComponentFixture<MovieTabComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MovieTabComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MovieTabComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
