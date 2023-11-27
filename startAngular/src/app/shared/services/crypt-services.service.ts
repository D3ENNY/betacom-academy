import { Injectable } from '@angular/core';
import * as forge from 'node-forge'

@Injectable({
	providedIn: 'root'
})
export class CryptService {

	rsa: any
	publicKey: any
	privateKey: any

	constructor() {
		this.rsa = forge.pki.rsa
		const keyPair = this.generateKeyPair()
		this.publicKey = keyPair.publicKey
		this.privateKey = keyPair.privateKey
	}

	convertPublicKey(publicKeyCs: string) {
		const modulusMatch = publicKeyCs.match(/<Modulus>(.*?)<\/Modulus>/s)
    	const exponentMatch = publicKeyCs.match(/<Exponent>(.*?)<\/Exponent>/s)

		if(!modulusMatch || !exponentMatch)
			throw new Error("formato della chiave pubblica non valido")

		return forge.pki.setRsaPublicKey(
			new forge.jsbn.BigInteger(forge.util.decode64(modulusMatch[1]), 256),
			new forge.jsbn.BigInteger(forge.util.decode64(exponentMatch[1]), 256)
		)
	}

	generateKeyPair() {
		const keys = forge.pki.rsa.generateKeyPair({ bits: 1024 });
		return {
			publicKey: forge.pki.publicKeyToPem(keys.publicKey),
			privateKey: forge.pki.privateKeyToPem(keys.privateKey),
		}
	}

	crypt(data: string): string {
		const key = forge.pki.publicKeyFromPem(this.publicKey);
		const encrypted = key.encrypt(forge.util.encodeUtf8(data));
		return forge.util.encode64(encrypted);
	}

	decrypt(encryptedData: string): string {
		const key = forge.pki.privateKeyFromPem(this.privateKey);
		const decrypted = key.decrypt(forge.util.decode64(encryptedData));
		return forge.util.decodeUtf8(decrypted);
	}
}