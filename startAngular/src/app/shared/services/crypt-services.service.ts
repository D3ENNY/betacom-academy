import { Injectable } from '@angular/core';
import * as forge from 'node-forge'

@Injectable({
	providedIn: 'root'
})
export class CryptService {

	rsa: any
	publicKey: any
	privateKey: any

	serverPublicKey: any

	constructor() {
		this.rsa = forge.pki.rsa
	}

	ngOnInit(): void {

		const keyPair = this.generateKeyPair()
		this.publicKey = keyPair.publicKey
		this.privateKey = keyPair.privateKey
		
		
	}

	generateKeyPair() {
		const keys = this.rsa.generateKeyPair({ bits: 1024 });
		return {
			publicKey: forge.pki.publicKeyToPem(keys.publicKey),
			privateKey: forge.pki.privateKeyToPem(keys.privateKey),
		}
	}

	crypt(data: string) {
		const publicKeyForge = forge.pki.publicKeyFromPem(this.serverPublicKey);
		const encryptedData = publicKeyForge.encrypt(data, 'RSA-OAEP');
	
		return encryptedData;
	  }

	decrypt(encryptedData: string): string {
		const key = forge.pki.privateKeyFromPem(this.privateKey);
		const decrypted = key.decrypt(forge.util.decode64(encryptedData));
		return forge.util.decodeUtf8(decrypted);
	}
}