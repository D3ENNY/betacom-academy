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
		this.start()
	}

	start(): void {
		if(this.publicKey === undefined && this.privateKey === undefined){
			const keyPair = this.generateKeyPair()
			this.publicKey = keyPair.publicKey
			this.privateKey = keyPair.privateKey		
		}
	}

	generateKeyPair() {
		const keys = this.rsa.generateKeyPair({ bits: 1024 });
		console.log("generazione chiavi effettuata");
		
		return {
			publicKey: forge.pki.publicKeyToPem(keys.publicKey),
			privateKey: forge.pki.privateKeyToPem(keys.privateKey),
		}
	}

	crypt(data: string) {	
		try {
			// Decodifica la chiave pubblica base64
			const decodedPublicKey = forge.util.decode64(this.serverPublicKey);
	
			// Crea un oggetto ASN.1 dalla chiave pubblica DER
			const asn1PublicKey = forge.asn1.fromDer(decodedPublicKey);
	
			// Ottieni l'oggetto chiave pubblica da ASN.1
			const publicKeyForge = forge.pki.publicKeyFromAsn1(asn1PublicKey);
	
			// Crittografa i dati con la chiave pubblica
			const encryptedData = forge.util.encode64(publicKeyForge.encrypt(data, 'RSA-OAEP'));
	
			return encryptedData;
		} catch (error) {
			console.error('Errore durante la crittografia:', error);
		}
		return ''
	}

	decrypt(encryptedData: string): string {
		const key = forge.pki.privateKeyFromPem(this.privateKey);
		const decrypted = key.decrypt(forge.util.decode64(encryptedData));
		return forge.util.decodeUtf8(decrypted);
	}

	convertFromPem(pk: string) {
		return pk.replace('-----BEGIN PUBLIC KEY-----', '')
		.replace('-----END PUBLIC KEY-----', '')
		.replace(/\n/g, '')
		.replace(/\r/g, '')
		.replace(/\t/g, '')
	}
}