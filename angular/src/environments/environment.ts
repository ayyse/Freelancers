 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44346/',
  redirectUri: baseUrl,
  clientId: 'Freelancers_App',
  responseType: 'code',
  scope: 'offline_access Freelancers',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Freelancers',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44346',
      rootNamespace: 'Freelancers',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
