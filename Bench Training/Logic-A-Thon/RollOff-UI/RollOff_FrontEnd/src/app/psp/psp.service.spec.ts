import { TestBed } from '@angular/core/testing';

import { PSPService } from './psp.service';

describe('PSPService', () => {
  let service: PSPService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PSPService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
