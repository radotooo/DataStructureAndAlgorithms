const crypto = require('crypto');

const password = 'demo'
const ENCRYPTION_KEY = crypto.createHash('md5').update(password).digest('hex'); // Must be 256 bits (32 characters)
const IV_LENGTH = 16

function encrypt(text, encryptionKey = ENCRYPTION_KEY) {
    let iv = Buffer.from(crypto.randomBytes(IV_LENGTH)).toString('hex').slice(0, IV_LENGTH);
    let cipher = crypto.createCipheriv('aes-256-cbc', Buffer.from(encryptionKey), iv);
    let encrypted = cipher.update(text);

    encrypted = Buffer.concat([encrypted, cipher.final()]);
    return iv + encrypted.toString('hex');
}

function decrypt(text, encryptionKey = ENCRYPTION_KEY) {
    let iv = Buffer.from(text.slice(0, 16), 'binary');
    let encryptedText = Buffer.from(text.slice(16), 'hex');
    let decipher = crypto.createDecipheriv('aes-256-cbc', Buffer.from(encryptionKey), iv);
    let decrypted = decipher.update(encryptedText);

    decrypted = Buffer.concat([decrypted, decipher.final()]);
    return decrypted.toString();
}

const encryptedData = encrypt('Hello World');
console.error(decrypt(encryptedData));
