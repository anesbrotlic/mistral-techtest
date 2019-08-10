import { TestBed } from '@angular/core/testing';

import { UserIndicatorsService } from './user-indicators.service';

describe('LoadingIndicatorService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: UserIndicatorsService = TestBed.get(UserIndicatorsService);
    expect(service).toBeTruthy();
  });
});
