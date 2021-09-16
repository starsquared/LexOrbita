import { interest } from './interest';
import { lawyerDetail } from './lawyerDetail';
import { photo } from './photo';

export interface userToDisplay {
  id: number;
  username: string;
  photoUrl: string;
  firstName: string;
  lastName: string;
  addressLine1: string;
  addressLine2: string;
  city: string;
  state: string;
  country: string;
  zipCode: string;
  phone: string;
  appUserType: string;
  created: Date;
  lastActive: Date;
  introduction: string;
  interests: interest[];
  photos: photo[];
  lawyerDetails: lawyerDetail[];
}
